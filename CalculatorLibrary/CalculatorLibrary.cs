using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace CalculatorLibrary
{
    public class Calculator
    {
        JsonWriter writer;
        public Calculator()
        {
            StreamWriter logFile = File.CreateText("calculatorlog.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }
        public double DoOperation(double n1, double n2, string opr)
        {
            double result = double.NaN;
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(n1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(n2);
            writer.WritePropertyName("Operation");
            
            switch (opr)
            {
                case "add":
                    result = n1 + n2;
                    writer.WriteValue("Add");
                    break;
                case "sub":
                    result = n1 - n2;
                    writer.WriteValue("Subtract");
                    break;
                case "mul":
                    result = n1 * n2;
                    writer.WriteValue("Multiply");
                    break;
                case "div":
                    if (n2 != 0)
                    {
                        result = n1 / n2;
                        writer.WriteValue("Divison");
                    }
                    break;
                default:
                    break;
            }
            writer.WritePropertyName("Result");
            writer.WriteValue(result);
            writer.WriteEndObject();

            return result;
        }

        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
    }
}