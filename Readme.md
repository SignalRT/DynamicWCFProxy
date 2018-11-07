# DynamicWFCProxy

This is an example of a dynamic WebProxy generator for an WCF / SOAP WebService.

It generates automatically the proxy and allow the method invocation.

The usage is very simple:



```c#
    static void Main(string[] args)
    {
		// Create the proxy
		//
        WebServiceInvoker ws = new WebServiceInvoker( new Uri(@"http://www.dneonline.com/calculator.asmx"));

		// Invokes the Add method 
		//
        Int32 result = ws.InvokeMethod<Int32>("CalculatorSoapClient", "Add", new object[2] { 2, 3 });
        
		// Write the results
		Console.WriteLine("Result: {0}", result);

        // Wait a key press
		//
        Console.ReadKey();
    }
```