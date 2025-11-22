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
/*document.getElementById('photoInput').addEventListener('change', function (e) {
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
});*/

/*$('.upload input').on('change', e => {
    const f = e.target.files[0];
    const img = $(e.target).siblings('img')[0];

    img.dataset.src ??= img.src;

    if (f && f.type.startsWith('image/')) {
        img.onload = e => URL.revokeObjectURL(img.src);
        img.src = URL.createObjectURL(f);
    }
    else {
        img.src = img.dataset.src;
        e.target.value = '';
    }

    // Trigger input validation
    $(e.target).valid();
});*/

//Reset Form
$('[type=reset]').on('click', e => {
    e.preventDefault();
    location = location;
});