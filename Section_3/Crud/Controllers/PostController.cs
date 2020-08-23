using System;
using Crud.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Crud.Controllers
{
public class PostController : Controller
    {

        private ForumContext db;
            public PostController(ForumContext context)
            {
                db = context;
            }

            private int? uid
            {
                get{
                    return HttpContext.Session.GetInt32("UserId");
                }
            }

            
            private bool isLoggedIn
            {
                get
                {
                    return uid != null;
                }
            }

            [HttpGet("/posts")]
            public IActionResult All()
            {
                if(!isLoggedIn)
                {
                    return RedirectToAction("Index","Home");
                }
                List<Post> allposts=db.Posts
                .Include(Post => Post.Author)
                .OrderByDescending(p => p.CreatedAt)
                .ToList();
                return View("All", allposts);
            } 
            [HttpGet("/posts/new")]
            public IActionResult New()
            {
                if(!isLoggedIn)
                {
                    return RedirectToAction("Index","Home");
                }
                return View("New");
            } 

            [HttpPost("/posts/create")]
            public IActionResult Create(Post newPost)
            {
                
                if(ModelState.IsValid ==false)
                {
                    return View("New");
                }
                newPost.UserId = (int)uid;
                db.Posts.Add(newPost);
                db.SaveChanges();
                return RedirectToAction("All", newPost);
            } 
            [HttpGet("/posts/{postId}")]
            public IActionResult Details(int postId)
            {
                if(!isLoggedIn)
                {
                    return RedirectToAction("Index","Home");
                }
                Post selectedPost =db.Posts.FirstOrDefault(post => post.PostId == postId);
                if (selectedPost ==null)
                {
                    return RedirectToAction("All");
                }
                return View("Details", selectedPost);
            } 

            [HttpPost("/posts/{PostId}/delete")]

            public IActionResult Delete(int PostId)
            {
                 Post selectedPost =db.Posts
                 .Include(Post => Post.Author)
                 .FirstOrDefault(post => post.PostId == PostId);
                
                if (selectedPost ==null)
                {
                 return RedirectToAction("Details",new{postId=PostId});
                }
                 db.Posts.Remove(selectedPost);
                    db.SaveChanges();
                return RedirectToAction("All");
            }

            [HttpGet("/posts/{PostId}/edit")]
            public IActionResult Edit(int PostId)
            {
                 Post selectedPost =db.Posts.FirstOrDefault(post => post.PostId == PostId);
                 if (selectedPost == null || selectedPost.UserId !=uid)
                 {
                     return RedirectToAction("All");
                 }

                 return View("Edit", selectedPost);
            }

            [HttpPost("/posts/{PostId}/update")]
            public IActionResult Update (Post editedPost, int PostId)
            {
                if (ModelState.IsValid ==false)
                {
                    return View ("All", editedPost);
                }

                Post selectedPost =db.Posts.FirstOrDefault(post => post.PostId == PostId);
                if ( selectedPost == null)
                {
                    return RedirectToAction("All");
                }
                selectedPost.Topic = editedPost.Topic;
                selectedPost.Body =editedPost.Body;
                selectedPost.ImgUrl=editedPost.ImgUrl;
                selectedPost.UpdatedAt=editedPost.UpdatedAt;
                db.Posts.Update(selectedPost);
                db.SaveChanges();

                return RedirectToAction("details", new {postId = PostId});
            }
            
    }

}