using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace DatabaseMigrations
{
    [Migration(201806190727)]
   public class Add_Day_Column_To_Car : Migration
    {
        public override void Up()
        {
            Create.Column("Day").OnTable("Cars").AsString(int.MaxValue).Nullable();
        }

        public override void Down()
        {
            Delete.Column("Day").FromTable("Cars");
        }

    }
}
