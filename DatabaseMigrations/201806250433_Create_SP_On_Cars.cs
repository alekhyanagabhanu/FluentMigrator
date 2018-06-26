using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;
namespace DatabaseMigrations
{

    [Migration(201806250433)]
    public class Create_SP_On_Cars : Migration
    {

        public override void Up()
        {
            Execute.EmbeddedScript("GetCars.sql");

        }

        public override void Down()
        {
            Execute.Sql("DROP PROCEDURE Get_Cars");
           
        }

       
    }
}
