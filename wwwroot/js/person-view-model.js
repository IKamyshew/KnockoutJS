var personViewModel;

$(function () {
    personViewModel = {
        id: ko.observable(1),
        firstName: ko.observable(''),
        lastName: ko.observable(''),
        age: ko.observable(0),
        gender: ko.observable(0),
        lastUpdated: ko.observable('')
    };

    ko.applyBindings(personViewModel);

    personViewModel.firstName('Igor');
    personViewModel.lastName('Kamyshev');
    personViewModel.age(23);
    personViewModel.gender(0);
    personViewModel.lastUpdated(currentTime());
});

function currentTime() {
    var currentdate = new Date();
    var datetime =
        currentdate.getDate() + "/"
        + (currentdate.getMonth() + 1) + "/"
        + currentdate.getFullYear() + " "
        + currentdate.getHours() + ":"
        + currentdate.getMinutes() + ":"
        + currentdate.getSeconds();

    return datetime;
}