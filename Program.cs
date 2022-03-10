global using System;
using DatabaseConnection.Db;
using DatabaseConnection.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

using (var context = new SchoolContext())
{

    var std = new Student()
    {
        Name = "Diego"
    };

    context.Students.Add(std);
    context.SaveChanges();
}



