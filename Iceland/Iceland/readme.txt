-----------------------------------------------------------------------------------------------------------------------------------------
Created using .Net Core 3.0 utilising Micrsoft Visual Studio Community Edition 2019

The application reads in the products.json file, there is a basic check to ensure the file exists, but currently no test to ensure the file contains the correct product JSON.

Once the products are read in and deserialised into a List of products the application iterates over them calling update.

Update applies the IQuality rule based upon the type of product.

-----------------------------------------------------------------------------------------------------------------------------------------
To Build the application, navigate to the solution directory, open a command prompt and type:

dotnet build Iceland.sln

To run the application, navigate to the bin directory: 

Iceland\Iceland\bin\Debug\netcoreapp3.0\

And run the Iceland.exe
-----------------------------------------------------------------------------------------------------------------------------------------

To test simply update the product.json file with data and run the application to see how it updates that data with the rules.

Product Types:
public enum ProductTypes
			{
				NormalItem = 0,
				AgedBrie = 1,
				BackStagePass = 2,
				Conjured = 3,
				Legendary = 4,
				Invalid = 5
			}

Example Product JSON:

{
	"ProductType": 3,
	"Name": "conjured1",
	"SellIn": -1,
	"Quality": 5
}


