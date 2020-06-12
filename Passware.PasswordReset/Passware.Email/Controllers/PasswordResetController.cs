using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EmailService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Passware.Email.Data;
using Passware.Email.Models;

namespace Passware.Email.Controllers
{
    //[Route("api/[controller]")]
    [Route("PasswordReset")]
    [ApiController]
    public class PasswordResetController : ControllerBase
    {
        private readonly PasswareEmailContext _context;

        private readonly IEmailSender _emailSender;
        public IMapper _mapper;
        public UserManager<User> _userManager;
        public SignInManager<User> _signInManager;


        public PasswordResetController(PasswareEmailContext context, IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager, IEmailSender emailSender)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
        }

        // POST: api/PasswordResets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task PostPasswordReset(Passware.Email.Models.ForgotPassword forgotPassword)
        {
            var user = await _userManager.FindByEmailAsync(forgotPassword.Email);
            //if (user == null)

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            var callback = Url.Action("ResetPassword", "AccountController", new { token, email = user.Email }, Request.Scheme);

            var message = new Message(new string[] { "passware.smtpserver@gmail.com" }, "Reset password token", callback);
            await _emailSender.SendEmailAsync(message);


        }
    }
}
