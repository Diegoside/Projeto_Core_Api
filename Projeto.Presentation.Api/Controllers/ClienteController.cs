﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto.Presentation.Api.Models;

namespace Projeto.Presentation.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ClienteController : ControllerBase
	{
		[HttpPost]
	    public IActionResult Post(ClienteCadastroModel model)
		{

			return Ok();

		}


		[HttpPut]
		public IActionResult Put (ClienteEdicaoModel model)
		{

			return Ok();

		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{

			return Ok();
		}

		[HttpGet]
		public IActionResult GetAll()
		{

			return Ok();


		}

	}
}
