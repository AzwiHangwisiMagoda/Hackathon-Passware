using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using User.Entities;
using User.Helpers;
using User.Services;
using AutoMapper;
using Microsoft.Extensions.Options;
using User.Models;

namespace User.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;
        private readonly AppSettings _appSettings;

        public UserController(
            IUserService userService,
            IMapper mapper,
            IOptions<AppSettings> appSettings)
        {
            _userService = userService;
            _mapper = mapper;
            _appSettings = appSettings.Value;
        }

        [HttpPut]
        public IActionResult Update(string username, [FromBody]UpdateModel model)
        {
            var user = _mapper.Map<UserEntity>(model);
            user.Username = username;

            try
            {
                _userService.Update(user, model.Password);
                return Ok();
            } catch(Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public IActionResult GetByUsername(string username)
        {
            var user = _userService.GetUserByUsername(username);
            var model = _mapper.Map<UserModel>(user);
            return Ok(model);
        }
    }
}
