function showBookingForm(carModel, price) {
    document.getElementById('carModel').value = carModel;
    document.getElementById('totalCost').value = '';
    document.getElementById('booking-form-container').style.display = 'block';
  }
  
  function calculateCost() {
    // Implement cost calculation logic here
    const pickupDate = new Date(document.getElementById('pickupDate').value);
    const dropoffDate = new Date(document.getElementById('dropoffDate').value);
    const timeDiff = dropoffDate - pickupDate;
    const days = Math.ceil(timeDiff / (1000 * 60 * 60 * 24));
    const pricePerDay = 50; // Change this value based on the actual pricing
    const totalCost = days * pricePerDay;
  
    document.getElementById('totalCost').value = 'Rs ' + totalCost;
  }
  
  function submitBooking() {
    document.getElementById('carModel').value = carModel;
    document.getElementById('pickupAddress').value = pickupAddress;
    document.getElementById('carNumber').value = carNumber;
    document.getElementById('pickupDate').value = pickupDate;
    document.getElementById('dropoffDate').value = dropoffDate;
    document.getElementById('totalCost').value = totalCost;

    if(carModel==="" || pickupAddress==="" || carNumber==="" || pickupDate==="" || dropoffDate==="" || totalCost==="")
    {
      alert('Fill in the form');
    }
    else
    {
    alert('Booking submitted successfully!');
    }
    document.getElementById('booking-form-container').style.display = 'none';
  }