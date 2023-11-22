document.addEventListener("DOMContentLoaded", function () {
  const header = document.querySelector('.header');
  const backToTopBtn = document.getElementById('backToTopBtn');

  window.addEventListener('scroll', function () {
    // Change header background color on scroll
    if (window.scrollY > 100) {
      header.style.backgroundColor = '#555';
    } else {
      header.style.backgroundColor = '#333';
    }

    // Show/hide "Back to Top" button
    if (window.scrollY > 500) {
      backToTopBtn.style.display = 'block';
    } else {
      backToTopBtn.style.display = 'none';
    }
  });

  // Scroll to the top when the "Back to Top" button is clicked
  backToTopBtn.addEventListener('click', function () {
    window.scrollTo({
      top: 0,
      behavior: 'smooth'
    });
  });
});
