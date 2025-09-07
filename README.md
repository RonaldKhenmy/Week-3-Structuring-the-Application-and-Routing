# Week-3-Structuring-the-Application-and-Routing
Dependency Injection involving interfaces and service implementation in MVC ASP.NET Core. This app allows users to store a list of products by entering the name of the item, release date, item type, and the price of the item. The application can edit, delete, and see the details of the products in the list. In the details page, you can see how many days an item has been purchased. Includes the usage of routing.

In order to run the app, download the zip folder and extract all the files. You can open up Visual Studio or double-click the folder to access the files. For direct access, double the folder and then double-click the folder MvcProduct. Click on the solution file to open it. If a textbox shows up that asks you to trust it, click okay/yes. Press the green play button that says https or press F5 on your keyboard. If there is a textbox asking you to trust a certificate, click yes. 

Running the program will open a website; the URL will be a localhost:<port#>(The port number is random). Click on the Product app header/link, which will lead you to the Index webpage, where you will find the list of items, release date, item type, and price. The header is located on the top left corner of the page. In order to add products, click on the 'Create new' link and fill in the boxes, and select a date. Finally, press the save button to store the item. When you click on the 'Details' link, you will see a link called 'View Days Since Purchased'. When you click on the link, it will bring you to a page that measures the days since the item was purchased. In order to get out of the page, click the Product app header. If you are done with the app, close the window by clicking on the X-button in the top right corner of the window. Make sure to also close the console command after closing the app afterwards. 

Update design-note: 
An interface and service folder were added to the project along with a new view. The app follows the Separation of Concerns by focusing on the single responsibility of measuring time using the interface and service implementation without interfering with the products. The reason AddScoped was used because I wanted services to be created once per client request, which is registered by IDaysPurchased. The reason I chose IDaysPurchased as my dependency injection was to measure the days the item was purchased. Other dependencies include MvcProductsContext for the database and ILogger to send logs to the console command.



Update route-map:
