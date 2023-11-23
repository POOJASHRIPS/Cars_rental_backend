import axios from 'axios';
document.addEventListener("DOMContentLoaded", function () {
    const customerForm = document.getElementById("customer-form");
    const switchidc = document.getElementById("switch-idc");
    const switchido = document.getElementById("switch-ido");
    const carOwnerForm = document.getElementById("car-owner-form");
    const loginToggle = document.getElementById("loginToggle");

    const showCustomerForm = () => {
        customerForm.style.display = "block";
        switchidc.style.display = "block";
        switchido.style.display = "none";
        carOwnerForm.style.display = "none";
    };

    const showCarOwnerForm = () => {
        customerForm.style.display = "none";
        switchidc.style.display = "none";
        switchido.style.display = "block";
        carOwnerForm.style.display = "block";
    };

    const handleToggleChange = () => {
        if (loginToggle.checked) {
            showCarOwnerForm();
        } else {
            showCustomerForm();
        }
    };

    loginToggle.addEventListener("change", handleToggleChange);

    showCustomerForm();
});

const signUp = async (userData, url) => {
    try {
        const response = await axios.post(url, userData);
        console.log(response.data); // Log the response from the server
        // Handle the response as needed (e.g., show a success message to the user)
    } catch (error) {
        console.error("Error signing up:", error.message);
        // Handle the error (e.g., show an error message to the user)
    }
};

customerForm.addEventListener("submit", function (event) {
    event.preventDefault(); // Prevent the default form submission

    const formData = new FormData(customerForm);
    const userData = {
        name: formData.get("customername"),
        contactNumber: formData.get("customerphonenumber"),
        drivingLicenseNumber: formData.get("customerDL"),
        email: formData.get("customermailID"),
        password: formData.get("customerPassword")
    };

    signUp(userData, "http:file:///C:/Training/Cars/CarRental.Web/Front%20End/signup.html"); // Replace with your actual backend API URL
});

carOwnerForm.addEventListener("submit", function (event) {
    event.preventDefault(); // Prevent the default form submission

    const formData = new FormData(carOwnerForm);
    const userData = {
        username: formData.get("carOwnerUsername"),
        contactNumber: formData.get("carOwnernumber"),
        carNumber: formData.get("carOwnercarnumber"),
        carType: formData.get("carOwnercartype"),
        email: formData.get("carOwnermailID"),
        password: formData.get("carOwnerPassword")
    };

    signUp(userData, "http:file:///C:/Training/Cars/CarRental.Web/Front%20End/signup.html"); // Replace with your actual backend API URL
});

