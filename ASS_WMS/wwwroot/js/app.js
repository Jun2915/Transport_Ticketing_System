function toogleMenu() {
    const menu = document.getElementById("profileMenu");
    menu.style.display = (menu.style.display === "block") ? "none" : "block";
}

window.addEventListener("click", function (event) {
    let menu = document.getElementById("profileMenu");
    let menu = document.getElementById("profileIcon");
    if (!menu.contains(event.target) && !icon.contains(event.target)) {
        menu.style.display = "none";
    }
});

// Photo preview
document.getElementById('photoInput').addEventListener('change', function (e) {
    const file = e.target.files[0];
    if (file) {
        const reader = new FileReader();
        reader.onload = function (e) {
            const preview = document.getElementById('photoPreview');
            preview.src = e.target.result;
            preview.style.display = 'block';
        }
        reader.readAsDataURL(file);
    }
});

// Update photo label based on user type
document.getElementById('userTypeSelect').addEventListener('change', function () {
    const photoLabel = document.querySelector('label[for="Photo"]');
    if (this.value === 'Admin') {
        photoLabel.textContent = 'Admin Profile Photo';
    } else if (this.value === 'Customer') {
        photoLabel.textContent = 'Customer Profile Photo';
    } else {
        photoLabel.textContent = 'Profile Photo';
    }
});