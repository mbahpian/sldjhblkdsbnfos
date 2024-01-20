@import url('https://fonts.googleapis.com/css2?family=Ms+Madi&family=Square+Peg&display=swap');

*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    text-decoration: none;
    text-transform: capitalize;
    font-family: 'Ms Madi', cursive;
    font-family: 'Square Peg', cursive;
    transition: all 0.2s linear;
}
body{
    background: #eee;
}
.container{
    width: 90%;
    margin: 0 auto;
    
}
.container .headeing{
    font-size: 3.2rem;
    color: #333;
    margin-bottom: 3rem;
    text-align: center;
}
.container .menu-container{
    display:grid;
    grid-template-columns: repeat(auto-fit,minmax(30%, 1fr));
    gap: 1rem;
    margin-bottom: 3rem;
}
.container .menu-container .menu{
    text-align: center;
    padding: 0.5rem;
    background: #fff;
    box-shadow: 0 0.5rem 1rem rgba(0, 0, 0, 0.3);
    cursor: pointer;
    outline: 0.1rem solid #ccc;
    outline-offset: -0.7rem;
}
.container .menu-container .menu:hover{
    outline-offset: 0;
    outline: 0.1rem solid #000;

}
.container .menu-container .menu img{
    width: 100%;
}
.container .menu-container .menu img:hover{
    transform: scale(.9);
}.container .menu-container .menu h3,
.container .menu-container .menu .price{
    font-size: 1.5rem;
    color: #333;
}
.menu-preview{
    position: fixed;
    top:0; left: 0;
    min-height: 100vh;
    width: 100%;
    background: rgba(0, 0, 0, 0.5);
    display: none;
    align-items: center;
    justify-content: center;
}
.menu-preview .preview{
    display: none;
    padding: 0.5rem; 
    text-align: center;
    position: relative;
    /* margin: 1rem; */
    width: 40%;
    background: #fff;
}
.menu-preview .preview img{
    width: 100%;
}
.menu-preview .preview.active{
    display: inline-block;
}
.menu-preview .preview h3{
    font-size: 2rem;
    color: #333;
}
.menu-preview .preview .stars{
    color: gold;
    font-size: 1.2rem;
}
.menu-preview .preview .stars li{  
    margin: 0 1rem ;
    
} 
.menu-preview .preview p{
    font-size: 1.8rem;
    color: #333;
}
.menu-preview .preview a{
    display: inline-block;
    width: 10rem; height: 2.6rem;
    background: gold;
    color: honeydew;
    font-size: 1.5rem;
    border: 0.1rem solid gold;
    border-radius: 0.5rem;
}
.menu-preview .preview a:hover{
    background: none;
    color: #333;
}
.menu-preview .preview .fa-xmark{
    position: absolute;
    top: 1rem;
    right: 1rem;
    font-size: 1.5rem;
    color: #333;
    cursor: pointer;
}
.menu-preview .preview .fa-xmark:hover{
    transform: rotate(180deg);
    color: gold;
}
