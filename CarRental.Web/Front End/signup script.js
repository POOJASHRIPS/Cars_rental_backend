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
