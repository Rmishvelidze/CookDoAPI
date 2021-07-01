﻿using CookDoWebAPI.Context;
using CookDoWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CookDoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class StudnetsController : ControllerBase
    {
        private readonly CRUDContext _CRUDContext;

        public StudnetsController(CRUDContext cRUDContext)
        {
            _CRUDContext = cRUDContext;
        }

        // GET: api/<StudnetsController>
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return  _CRUDContext.Students;
        }

        // GET api/<StudnetsController>/5
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            return _CRUDContext.Students.SingleOrDefault(x => x.StudentId == id);
        }

        // POST api/<StudnetsController>
        [HttpPost]
        public void Post([FromBody] Student student)
        {
            _CRUDContext.Students.Add(student);
            _CRUDContext.SaveChanges();
        }

        // PUT api/<StudnetsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student student)
        {
            student.StudentId = id;
            _CRUDContext.Students.Update(student);
            _CRUDContext.SaveChanges();
        }

        // DELETE api/<StudnetsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _CRUDContext.Students.FirstOrDefault(x => x.StudentId == id);
            if (item != null)
            {
                _CRUDContext.Students.Remove(item);
                _CRUDContext.SaveChanges();
            }
        }
    }
}
