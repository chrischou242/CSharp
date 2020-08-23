using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bank_Accounts.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Bank_Accounts.Controllers
{
    public class MoneyController : Controller
    {
        private Bank_AccountsContext db;
        public MoneyController(Bank_AccountsContext context)
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

        [HttpGet("Money")]
        public IActionResult ViewMoney()
        {
             if(!isLoggedIn)
            {
                return RedirectToAction("Index","Home");
            }
            NewWithdrawWrapper withdraw = new NewWithdrawWrapper();
            withdraw.Transcations = db.Transactions
            .Include(U =>U.Creater)
            .ToList();
            return View("Transactions",withdraw);

        }

        [HttpPost("Deposit_Withdraw")]
        public IActionResult Create_Deposit_Withdraw(NewWithdrawWrapper NewWithdraw, int UserID)
        {
            if(!isLoggedIn)
            {
                return RedirectToAction("Index","Home");
            }
            if(ModelState.IsValid ==false)
            {
                NewWithdrawWrapper MoneyWrapper = new NewWithdrawWrapper();
                MoneyWrapper.Transcations = db.Transactions.ToList(); 
                    return View("NewDish",MoneyWrapper);
            }
           
            NewWithdraw.Form.UserId = (int)uid;
            db.Transactions.Add(NewWithdraw.Money);
            db.SaveChanges();
            return RedirectToAction("ViewMoney");
        }
    }
}




