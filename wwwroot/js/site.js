// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


$(function () {
	var ajaxFormSubmit = function () {
		var $form = $(this);
		var options = {
			url: $form.attr("action"),
			type: $form.attr("method"),
			data: $form.serialize()
		};
		$.ajax(options).done(function (data) {
			var $target = $($form.attr("data-otf-target"));
			$target.replaceWith(data);
		});
		return false;
	};

	var getPage = function () {
		var $a = $(this);
		var options = {
			url: $a.attr("href"),
			type: "get"
		}
		$.ajax(options).done(function (data) {
			var target = $a.parents("div.pagedList").attr("data-otf-target");
			$(target).replaceWith(data);
		}};
		return false;
	});

	$("form[data-otf-ajax='true']").submit(ajaxFormSubmit);
	$("input[data-otf-autocomplete]").each(createAutocomplete);

$("main").on("click", ".pagedList a", getPage);
});