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

// function getdata() {
//     var formvalue = document.forms("")
//     axios.post("https://localhost:7117/Register",
//       {
//         Name: 'sample',
//         ContactNumber: '9562358956',
//         Email:'sample@gmail.com',
//         DrivingLicenseNumber:'KA54585',
//         Password:'Checkthis2',
//       })
//       .then((res) => {
//         console.log(res);
//       });
//   }

// function getdata() {
//     // Get form values
//     var formValues = {
//         name: document.getElementById('Name')?.value,
//       ContactNumber: document.getElementById('ContactNumber')?.value,
//       email: document.getElementById('Email')?.value,
//       DrivingLicenseNumber: document.getElementById('DrivingLicenseNumber')?.value,
//       password: document.getElementById('Password')?.value,
//     };

//     // Post data to the server
//     axios.post("https://localhost:7117/Register", formValues)
//         .then((res) => {
//         })
//         .catch((error) => {
//             console.error("Error:", error);
//         });
// }



// const baseUrl = 'localhost:7117';

// Handler for logging inside the application
const getdata = async () => {
    const headers = {
        "Content-Type": "application/json",
        // Authorization: apiKey,
      };
      
    // const PasswordChecker1 = document.getElementById('Password');
    // const PasswordChecker2 = document.getElementById('Password1');
    // // const MailIDChecker = document.getElementById('Email');
    // if (PasswordChecker1 != PasswordChecker2) {
    //     alert("Password does not match");
    //     return false;
    // }
    // else {
        event.preventDefault();
        debugger

        const url = `http://localhost:7117/GetAllCars`;
        const payload = {};
    
            var response = axios.get(url, { headers })
            .then(function(response) {
                console.log(response);
            })
            .catch (function(e){console.log(e);}) 


        // const name = document.getElementById('Name')?.value;
        // const contactNumber = document.getElementById('ContactNumber')?.value;
        // const email = document.getElementById('Email')?.value;
        // const drivingLicenseNumber = document.getElementById('DrivingLicenseNumber')?.value;
        // const password = document.getElementById('Password')?.value;

        // const url = `http://localhost:7117/Register`;
        // const payload = {
        //     "Name": name,
        //     "ContactNumber": contactNumber,
        //     "Email": email,
        //     "DrivingLicenseNumber": drivingLicenseNumber,
        //     "Password": password
        // };


        // try {
        //     const response = await axios.post(url, payload);
        //     console.log(response.data);
        //     // Handle the response data or update UI here
        // } catch (err) {
        //     console.error(err);
        //     // Handle errors here
        // }
    }
//}

const registrationForm = document.getElementById('customer-form');
registrationForm.addEventListener('submit', getdata);



// const axios = require('axios');

// // Set up the proxy configuration
// const proxyConfig = {
//   host: 'https://localhost',  // Replace with the actual host of your proxy
//   port: 7117,               // Replace with the actual port of your proxy
// };

// // Create an Axios instance with the proxy configuration
// const axiosWithProxy = axios.create({
//   proxy: proxyConfig
// });

// var formValues;

// function getdata() {
//     // Get form values
//     formValues = {
//         name: document.getElementById('Name')?.value,
//       ContactNumber: document.getElementById('ContactNumber')?.value,
//       email: document.getElementById('Email')?.value,
//       DrivingLicenseNumber: document.getElementById('DrivingLicenseNumber')?.value,
//       password: document.getElementById('Password')?.value,
//     };
// }

// // Make a request using the Axios instance with proxy configuration
// axios.post('https://localhost:7117/Register', getdata.formValues)
//   .then(response => {
//     console.log(response.data);
//   })
//   .catch(error => {
//     console.log('Error:');
//   });
