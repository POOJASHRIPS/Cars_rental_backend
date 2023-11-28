function callalert() {
    const mailID = document.getElementById("MailID").value;
    if (mailID === "") {
        alert("Fill in the Mail ID");
    }
    else {
        alert("Mail sent successfully to " + mailID);
    }
}