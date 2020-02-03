using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeFramework.Business.Abstract;
using HomeFramework.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HomeFramework.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }
        [HttpGet("getall")]
        [Authorize(Roles = "Article.GetList")]
        public IActionResult GetList()
        {
            var result = _articleService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getlistbycategory")]
        [Authorize(Roles = "Article.GetListByCategory")]
        public IActionResult GetListByCategory(int categoryId)
        {
            var result = _articleService.GetListByCategory(categoryId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        [Authorize(Roles = "Article.GetByid")]
        public IActionResult GetById(int articleId)
        {
            var result = _articleService.GetById(articleId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        [Authorize(Roles = "Article.Add")]
        public IActionResult Add(Article article)
        {
            var result = _articleService.Add(article);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        [Authorize(Roles = "Article.Update")]
        public IActionResult Update(Article article)
        {
            var result = _articleService.Update(article);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        [Authorize(Roles = "Article.Delete")]
        public IActionResult Delete(Article article)
        {
            var result = _articleService.Delete(article);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}