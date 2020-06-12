using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Email.Data;
using Email.Models;
using EmailService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace Email.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PasswordResetController : ControllerBase
    {
        private readonly EmailContext _context;

        private readonly IEmailSender _emailSender;
        public IMapper _mapper;
        public UserManager<User> _userManager;
        public SignInManager<User> _signInManager;


        public PasswordResetController(EmailContext context, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
            EmailSeeder.PopulateTestData(_context);
        }

        // POST: api/PasswordResets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        [Route("[controller]/PostPasswordReset")]
        public async Task<string> PostPasswordReset(/*ForgotPass forgotPassword*/)
        {
            //var user = await _userManager.FindByEmailAsync(forgotPassword.Email);
            //if (user == null)
            var user = new User()
            {
                Email = "azwi.magoda@iress.com",
                FirstName = "Azwi",
                Id = 2,
                LastName = "Magoda",
                Username = "AzwiMagoda"
            };

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action("ResetPassword", "AccountController", new { token, email = user.Email }, Request.Scheme);

            var message = new Message(new string[] { "passware.smtpserver@gmail.com" }, "Reset password token", callback);
            await _emailSender.SendEmailAsync(message);

            return "completed";
        }
    }
}
