// The simple idea of the MVVM pattern is to break the wall between the view and model:
    // The view knows its model and can manipulate the model directly
    // The view's model (view model) responds to the user operations directly
    // The view's model (view model) can actively notify the view how to render it (the model)
    // The controller's responsibilities are redistributed to view model
// Because the controller can disappear completely from a well-designed, model-enhanced 
// pattern, the name of MVC should change to MV. But the name of MV is too short, ambiguous, and 
// doesn't highlight the enhanced view-model, hence the name Model-View-ViewModel (MVVM)was born.


//--------------------------------------------------------------------------------------------------

// For example, in a button event handler method, we can validate the text in text boxes, 
// extract the value from the selected item in a dropdown list, 
// examine if checkboxes are checked, and then talk to the local file system, 
// database or web services to persist the data. We call this methodology rapid-application-development (RAD).

// RAD is just fine for small applications, but when applications grow larger and larger, 
// the relationships between the UI instances start getting messy. 
// Especially when multiple developers are working on code for the same group of UIs, 
// trying to understand the logic from other developers starts to get harder and harder. 
// The cost of maintaining the code, resolving code conflict, and fixing bugs go up.


//--------------------------------------------------------------------------------------------------

// The Implementations of an MVC Pattern

// RAD + MVC pattern: for example, Windows Forms is a plain RAD framework for Windows, 
// when writing a Windows Forms program, instead of putting all code in the event handlers, 
// you can create models, views, and controllers to enjoy the benefits of the MVC pattern

// RAD + MVC framework: to avoid reinventing the wheel, 
// developers created many reusable MVC frameworks for those plain RAD frameworks. 
// HTML+JavaScript is the traditional web client RAD framework; 
// it's hard to create an enterprise level web application using just pure HTML+JavaScript. 
// Angular is an MVC framework for HTML web client development. Once you use HTML and the Angular 
// framework together, your web application becomes an MVC application.

// MVC application framework: there are many MVC application frameworks, such as ASP.NET MVC, ASP.NET Core, 
// and Spring MVC. The difference between using an MVC application framework and using a RAD + MVC framework 
// is, once you build an application on the MVC application framework, the application is 
// constrained to be an MVC application naturally and you have no chance to make it non-MVC.