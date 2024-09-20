// JavaScript para menú móvil
document.querySelector('.menu-icon').addEventListener('click', () => {
    const menu = document.querySelector('.menu');
    if (menu.style.display === 'flex') {
        menu.style.display = 'none';
    } else {
        menu.style.display = 'flex';
    }
});
