using System;

while (true) {
    int IntValue;
    Console.WriteLine ("Enter a Integer value to see its HexaDecimal & Binary Conversions:");
    bool result = int.TryParse (Console.ReadLine (), out IntValue);
    if (result) {
        Console.WriteLine ($"Integer Value:{IntValue}");
        String HexaValue = IntValue.ToString ("X");
        String BinValue = Convert.ToString (IntValue, 2);
        Console.WriteLine ($"HexaDecimal value:{HexaValue}");
        Console.WriteLine ($"Binary Value:{BinValue}");
    } else {
        Console.WriteLine ("Invalid input");
        break;
    }
}