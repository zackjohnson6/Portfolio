<!--Zack Johnson, ZAC221539, 3/26/23 -->
<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <link href="style.css" rel="stylesheet" type="text/css" />
    <title>Index 2</title>
</head>
<body>
<?php
require_once 'LoginBox.php';

// instantiate the LoginBox object
$loginBox = new LoginBox();

// set the submit button to "check me" using function
$loginBox->setSubmitButtonLabel('Check Me');

// check if the form is submitted
if (isset($_POST['submit'])) {
  // get the username and password from the form
  $username = $_POST['username'];
  $password = $_POST['password'];

  // authenticate the user
  if ($loginBox->authenticate($username, $password)) {
    // redirect to success page
    $loginBox->successRedirect();
    exit();
  } else {
    // redirect to failed page
    $loginBox->failRedirect();
    exit();
  }
}

// display the login form
echo $loginBox->getLoginForm();
?>
</body>
</html>