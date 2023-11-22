document.addEventListener("DOMContentLoaded", function () {
    const dateInput = document.getElementById("datepicker");

    flatpickr(dateInput, {
        enableTime: true, // Set to true if you want to enable time selection
        dateFormat: "Y-m-d", // Customize the date format as needed
        minDate: "today", // Set the minimum date to today
    });//use .value to inherit the value
});

document.addEventListener("DOMContentLoaded", function () {
    const dateInput2 = document.getElementById("datepicker2");

    flatpickr(dateInput2, {
        enableTime: true, // Set to true if you want to enable time selection
        dateFormat: "Y-m-d", // Customize the date format as needed
        minDate: "today", // Set the minimum date to today
    });
});