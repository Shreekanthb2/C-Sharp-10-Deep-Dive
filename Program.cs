// Global using Directive
global using Newtonsoft.Json;
using C_Sharp_10_Deep_Dive.Source;

Console.WriteLine("Hello, World!");

var jsonSample = new JsonSample();
jsonSample.SerializeJSON();

// Constant Interpolated Strings
const string Name = "XYZ";
const string Designation = $"{Name} - Employee";


var lambaExpression = new LambdaExpressions();
lambaExpression.PrintData();

// Null Paramter Check
var nullParameterCheck = new NullParameterCheck();
nullParameterCheck.FormatName(null);
nullParameterCheck.StringifyCustomClass(null);

// Extended Property Pattern
var person = new Person() {
    Name="abc",
    Id=123,
    ResidentialsAddress = { HouseNumber = "#1234" }
};

var person1 = new Person()
{
    Name = "abc",
    Id = 123,
    ResidentialsAddress.HouseNumber = "#1234" 
};

// Record Structs
var recordStructs = new RecordStructs();
recordStructs.Sample();

