using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace number.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class NumberController : ControllerBase
	{

		private readonly ILogger<NumberController> _logger;

		public NumberController(ILogger<NumberController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public string random()
		{
			return new Car().Uri;			
		}
	}
}
