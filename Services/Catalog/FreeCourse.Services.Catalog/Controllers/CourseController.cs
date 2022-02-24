using FreeCourse.Services.Catalog.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FreeCourse.Shared;
using FreeCourse.Services.Catalog.Dto;

namespace FreeCourse.Services.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : FreeCourse.Shared.ControllerBases.CustomBaseController
    {
        private readonly ICourseServices _courseServices;

        public CourseController(ICourseServices courseServices)
        {
            _courseServices = courseServices;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _courseServices.GetAllAsync();
            return CreateActionResultInstance(response);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
             var response = await _courseServices.GetByIdAsync(id);
            return CreateActionResultInstance(response);
        }
        [HttpGet]
        [Route("/api[controller]/GetAllByUserId/{userId}")]
        public async Task<IActionResult> GetAllByUserId(string userId )
        {
            var response = await _courseServices.GetByIdAsync(userId);
            return CreateActionResultInstance(response);
        }
        [HttpPost]
        public async Task<IActionResult> Create(CourseCreateDto courseCreateDto)
        {
            var response = await _courseServices.CreateAsync(courseCreateDto);
            return CreateActionResultInstance(response);
        }
        [HttpPut]
        public async Task<IActionResult> Update(CourseUpdateDto courseUpdateDto)
        {
            var response = await _courseServices.UpdateAsync(courseUpdateDto);
            return CreateActionResultInstance(response);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _courseServices.DeleteAsync(id);
            return CreateActionResultInstance(response);
        }


    }
}
