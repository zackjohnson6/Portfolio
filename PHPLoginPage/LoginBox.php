<!--Zack Johnson, ZAC221539, 3/26/23 -->
<?php

/**
 * Define Class
 * A class for generating a login form and authenticating username/password
 */
class LoginBox {
  // define username
  private $username;

  // define password
  private $password;

  // default submit button label
  protected $submitButtonLabel = 'Submit';


  /**
   * Constructs a PHPPage object.
   *
   * @param string $title
   *  The value for the title property.
   */
  function __construct(string $label = 'Submit') {
    $this->submitButtonLabel = $label;
    $this->username = 'admin';
    $this->password = 'password123';
  }

  //Generates a login form with username and password fields, and a submit button
   public function getLoginForm() {
        $form = '<form method="post" action="index.php">';
        $form .= '<label for="username">Username:</label>';
        $form .= '<input type="text" id="username" name="username"><br>';
        $form .= '<label for="password">Password:</label>';
        $form .= '<input type="password" id="password" name="password"><br>';
        $form .= '<input type="submit" name="submit" value="' . $this->
          submitButtonLabel . '">';
        $form .= '</form>';


        return $form;
    }


    //Sets the label of the submit button
    public function setSubmitButtonLabel($label) {
        $this->submitButtonLabel = $label;
    }

    //Authenticates the username and password
    public function authenticate($username, $password) {
      try {
          if ($username != $this->username) {
              throw new Exception("Invalid username! ");
          }
          if ($password != $this->password) {
              throw new Exception("Invalid password! ");
          }
          return true;
        } catch (Exception $e) {
            echo "Error: " . $e->getMessage();
            return false;
        }
    }

     //Redirects the user to a success page
     public function successRedirect() {
        header("refresh:3;url=success.php");
        echo "Login successful! Redirecting to success page in 3 seconds...";
    }


      //Redirects the user to a failed page
      public function failRedirect() {
        header("refresh:3;url=failed.php");
        echo "Login failed! Redirecting to failed page in 3 seconds...";
    }
}
?>