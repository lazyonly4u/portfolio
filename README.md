
<!DOCTYPE html>
<html lang="en">
<head>
<title>CSS Template</title>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1">
<style>
* {
  box-sizing: border-box;
}

body {
  font-family: Times New Roman;
}

/* Style the header */
header {
  background-color:hsl(221, 54%, 26%);
  padding: 15px;
  text-align: center;
  font-size: 35px;
  color:white;
}



/* Create two columns/boxes that floats next to each other */
nav {
  float: left;
  width: 23%;
  height: 900px;
  background: hsl(221, 30%, 80%);
  padding: 15px;
}

/* Style the list inside the menu */
nav ul {
  list-style-type: none;
  padding: 0;
}

img {
  width: 100%;
}

article {
  float: left;
  padding: 20px;
  width: 75%;
  background-color: hsl(221, 38%, 97%);
  height: 900px; 
}

/* Clear floats after the columns */
section::after {
  content: "";
  display: table;
  clear: both;
}

/* Style the footer */
footer {
  background-color: hsl(221, 87%, 12%);
  padding: 10px;
  text-align: center;
  color: white;
}

/* Responsive layout - makes the two columns/boxes stack on top of each other instead of next to each other, on small screens */
@media (max-width: 600px) {
  nav, article {
    width: 100%;
    height: auto;
  }
}
</style>
</head>
<body>



<header>
  <h2>Portfolio</h2>
</header>

<section>
  <nav>
  <img src="img_girl.jpg" alt="Girl in a jacket" style="width:175px;height:200px;">
    <ul>
      <li><a href="file:///C:/Users/tanshr/Documents/Tanu%20files/CV.html">CV</a></li>
      <li><a href="https://github.com/lazyonly4u">Github-profil</a></li>
      <li><a href="https://linkedin.com/in/tanushree-shrestha-790824303/">LinkedIn</a></li>
    </ul>
    <h1>-Fakta- </h1>
    <p>-Blah </p>
    <p>-Blah </p>
    <p>-Blah </p>
    <p>-Blah </p>
    <p>-Blah </p>
    <p>-Blah </p>
    <p>-Blah </p>
    <p>-Blah </p>
    <p>-Blah </p>
    <p>-Blah </p>
    <img src="img_chania.jpg" alt="Flowers in Chania" style="width:175px;height:180px;">
  </nav>
  
  <article>
    <h1>-Biografiske oplysninger-</h1>
    <p>BlahBlahBlahBlahBlahBlah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlah. BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, Blah, Blah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlah. BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlah. BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah.</p>
    <p>BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlah. BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah.</p>
    
    <h1>-Karriereoversigt- </h1>
    <p> BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah.p>
    <p>BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah. BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah. </p>
    
    <h1>Liste over min færdigheder</h1>
    <p>BlahBlahBlahBlahBlahBlah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlah. BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, Blah, Blah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlah.</p> <p>BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlah. BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah.</p>
    <p>BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah, BlahBlahBlah. BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah.</p>
    <p> BlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlahBlah.p>
    
  </article>
</section>

<footer>
  <p>Footer</p>
</footer>

</body>
</html>
