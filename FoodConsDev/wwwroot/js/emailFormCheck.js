document.addEventListener("DOMContentLoaded", function() {
    document.getElementById('myForm').addEventListener('submit', function(event) {
        var emailField = document.getElementById('emailField');
        var emailValue = emailField.value;

        var emailPattern = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;

        if (!emailPattern.test(emailValue)) {
            alert('Please enter a valid email address.');
            event.preventDefault();
        }
    });
});