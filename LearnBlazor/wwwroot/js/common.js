window.sidebar = {
	toggle: function () {
		const element = document.querySelector('.sidebar');
		if (!element)
			return;

		element.classList.toggle('sidebar-collapse');
	}
};

window.showToastr = function (type, title, message) {
	switch (type) {
		case 'info': toastr.info(message, title); break;
		case 'success': toastr.success(message, title); break;
		case 'warning': toastr.warning(message, title); break;
		case 'error': toastr.error(message, title); break;
	}
}

window.showSweetAlert = async function (icon, title, text, cancelButtonText, confirmButtonText) {
	if (icon === 'question') {
		const result = await Swal.fire({
			icon: icon,
			title: title,
			text: text,
			showCloseButton: true,
			showCancelButton: true,
			confirmButtonText: `<i class="bi bi-hand-thumbs-up me-2"></i>` + confirmButtonText,
			cancelButtonText: `<i class="bi bi-hand-thumbs-down me-2"></i>` + cancelButtonText
		});

		return result.isConfirmed;
	}

	Swal.fire({
		icon: icon,
		title: title,
		text: text,
	});
}

window.showDatePicker = (elementId) => {
	const element = document.getElementById(elementId);

	console.log("showDatePicker Invoked...");

	if (element && typeof element.showPicker === 'function') {
		element.showPicker();
	}
}