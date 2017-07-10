﻿using System;
using Microsoft;
using MongoDB.Bson;
using MongoDB.Driver.Core;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {

       

        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

       // public DbSet<TodoItem> TodoItems { get; set; }

    }
}