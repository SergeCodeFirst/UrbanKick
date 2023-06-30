//=========== MENU SHOW ===========
const ShowMenu = (toggleId, navId) => {
    const toggle = document.getElementById(toggleId)
    const nav = document.getElementById(navId)

    if(toggle && nav){
        toggle.addEventListener("click", () => {
            nav.classList.toggle("show")
        })
    }
}

ShowMenu("nav-toggle", "nav-menu")

//=========== REMOVE MENU ===========
const navLink = document.querySelectorAll(".nav__item")
const navMenu = document.getElementById("nav-menu")

function linkAction(){
    navMenu.classList.remove("show");
}

navLink.forEach(n => n.addEventListener("click", linkAction));

//=========== SCROLL SECTIONS ACTIVE LINK ===========
const sections = document.querySelectorAll("section[id]")

window.addEventListener("scroll", scrollActive)

function scrollActive(){
    const scrollY = window.pageYOffset

    sections.forEach(current => {
        const sectionHeight = current.offsetHeight
        const sectionTop = current.offsetHeight - 50
        sectionId = current.getAttribute('id')

        if(scrollY > sectionTop && scrollY <= sectionTop + sectionHeight){
            document.querySelector(".nav__menu a[href*=" + sectionId+"]").classList.add('active')
        } else{
            document.querySelector(".nav__menu a[href*=" + sectionId+"]").classList.remove('avtive')
        }
    })

}

//=========== CHANGE COLOR HEADER ===========



