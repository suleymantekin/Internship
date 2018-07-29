// The simple idea of the MVVM pattern is to break the wall between the view and model:
    // The view knows its model and can manipulate the model directly
    // The view's model (view model) responds to the user operations directly
    // The view's model (view model) can actively notify the view how to render it (the model)
    // The controller's responsibilities are redistributed to view model
// Because the controller can disappear completely from a well-designed, model-enhanced 
// pattern, the name of MVC should change to MV. But the name of MV is too short, ambiguous, and 
// doesn't highlight the enhanced view-model, hence the name Model-View-ViewModel (MVVM)was born.