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
  padding: 20px;
  text-align: center;
  font-size: 30px;
  color:white;
}



/* Create two columns/boxes that floats next to each other */
nav {
  float: left;
  width: 25%;
  height: 525px;
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
  height: 525px; 
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
  padding: 20px;
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
  <h2>Hi! Jeg hedder Tanushree Shrestha</h2>
</header>

<section>
  <nav>
  <img src="img_girl.jpg" alt="Girl in a jacket" style="width:175px;height:200px;">

    <h1>Tanushree
    Shrestha</h1>
    <p>front and backend Programmer </p>
    
    <ul>
      <li><a href="file:///C:/Users/tanshr/Documents/Tanu%20files/CV.html">CV</a></li>
      <li><a href="https://github.com/lazyonly4u">Github-profil</a></li>
      <li><a href="https://linkedin.com/in/tanushree-shrestha-790824303/">LinkedIn</a></li>
    </ul>

  </nav>
  
  <article>

    <p style="font-size:160%;">I am an eager thinker, with an immense passion for creativity may it be in ways such as of problem solving or designing.</p>

    
    <h1>-break- </h1>
    <p> ⋆ ˚｡⋆୨୧ ⁺˚⋆｡°✩₊⋆ ˚｡⋆୨୧ ⁺˚⋆｡°✩₊⋆ ˚｡⋆୨୧ ⁺˚⋆｡°✩₊⋆ ˚｡⋆୨୧ ⁺˚⋆｡°✩₊⋆ ˚｡⋆୨୧ ⁺˚⋆｡°✩₊⋆ </p>
    
    <h1>body</h1>
    <p style="font-size:110%;">I am a programmer studying 'EUX Datatekniker specializing in programming' at TEC. I was originally from Nepal, but I am now a citizen of Denmark. When I was younger, I didn’t have a strong interest in IT. However, as I grew older, I realized how much our world relies on this field. My interest developed and continued to grow as I began reflecting on the past, present, and future—and how rapidly civilization is evolving. I want to be part of that progress. But it doesn’t stop there: I yearn to help and assist, whether in small or big ways. I aspire to create something—simple or complex—that is useful. Whether it's for entertainment or part of a larger project that drives change, I want to contribute.</p>


    
  </article>
</section>

<footer>
  <p>Find me on social media?</p>

</footer>

</body>
</html>
