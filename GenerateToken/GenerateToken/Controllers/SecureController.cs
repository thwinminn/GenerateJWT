﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenerateToken.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SecureController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult GetSecureData()
        {
            return Ok(new { message = "This is a secure endpoint." });
        }
    }
}
