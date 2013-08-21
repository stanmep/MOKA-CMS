// $(selector).event(callback)

(function ($) {
	var documentReady = function () {
		$("#signin").click(function () {
			var username = $("#username").val();
			var password = $("#password").val();

			var submit = false;
			$.each(users, function (i, user) {
				var keepgoing = true;
				if (user.username == username && user.password == password) {
					submit = true;
					keepgoing = false;
				} else {
					$("body").css("background-color", "red");
					$("#login-message").html("Username or Password was invalid");
				}
				return keepgoing;
			});
			return submit;
		});
	};

	$(document).ready(documentReady);
})(jQuery);
