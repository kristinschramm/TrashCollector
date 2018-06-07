namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InputStates : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO States Values('Alabama', 'AL')");
            Sql("INSERT INTO States Values('Alaska','AK')");
            Sql("INSERT INTO States Values('Arizona','AZ')");
            Sql("INSERT INTO States Values('Arkansas','AR')");
            Sql("INSERT INTO States Values('California','CA')");
            Sql("INSERT INTO States Values('Colorado','CO')");
            Sql("INSERT INTO States Values('Connecticut','CT')");
            Sql("INSERT INTO States Values('Delaware','DE')");
            Sql("INSERT INTO States Values('Florida','FL')");
            Sql("INSERT INTO States Values('Georgia','GA')");
            Sql("INSERT INTO States Values('Hawaii','HI')");
            Sql("INSERT INTO States Values('Idaho','ID')");
            Sql("INSERT INTO States Values('Illinois','IL')");
            Sql("INSERT INTO States Values('Indiana','IN')");
            Sql("INSERT INTO States Values('Iowa','IA')");
            Sql("INSERT INTO States Values('Kansa','KS')");
            Sql("INSERT INTO States Values('Kentucky','KY')");
            Sql("INSERT INTO States Values('Louisiana','LA')");
            Sql("INSERT INTO States Values('Maine','ME')");
            Sql("INSERT INTO States Values('Maryland','MD')");
            Sql("INSERT INTO States Values('Massachusetts','MA')");
            Sql("INSERT INTO States Values('Michigan','MI')");
            Sql("INSERT INTO States Values('Minnesota','MN')");
            Sql("INSERT INTO States Values('Mississippi','MS')");
            Sql("INSERT INTO States Values('Missouri','MO')");
            Sql("INSERT INTO States Values('Montana','MT')");
            Sql("INSERT INTO States Values('Nebraska','NE')");
            Sql("INSERT INTO States Values('Nevada','NV')");
            Sql("INSERT INTO States Values('New Hampshire','NH')");
            Sql("INSERT INTO States Values('New Jersey','NJ')");
            Sql("INSERT INTO States Values('New Mexico','NM')");
            Sql("INSERT INTO States Values('New York','NY')");
            Sql("INSERT INTO States Values('New Hampshire','NH')");
            Sql("INSERT INTO States Values('North Carolina','NC')");
            Sql("INSERT INTO States Values('North Dakota','ND')");
            Sql("INSERT INTO States Values('Ohio','OH')");
            Sql("INSERT INTO States Values('Oklahoma','OK')");
            Sql("INSERT INTO States Values('Oregon','OR')");
            Sql("INSERT INTO States Values('Pennsylvania','PA')");
            Sql("INSERT INTO States Values('Rhode Island','RI')");
            Sql("INSERT INTO States Values('South Carolina','SC')");
            Sql("INSERT INTO States Values('South Dakota','SD')");
            Sql("INSERT INTO States Values('Tennessee','TN')");
            Sql("INSERT INTO States Values('Texas','TX')");
            Sql("INSERT INTO States Values('Utah','UT')");
            Sql("INSERT INTO States Values('Vermont','VT')");
            Sql("INSERT INTO States Values('Virgina','VA')");
            Sql("INSERT INTO States Values('Washington','WA')");
            Sql("INSERT INTO States Values('West Virgina','WV')");
            Sql("INSERT INTO States Values('Wisconsin','WI')");
            Sql("INSERT INTO States Values('Wyoming','WY')");
        }
        
        public override void Down()
        {
        }
    }
}
