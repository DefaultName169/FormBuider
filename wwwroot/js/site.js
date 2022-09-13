
jQuery(document).ready(function ($) {
	$("#submit").click(function () {
		var list = [];
		for (var i = 0; i < $(".child-box").length; i++) {
			var obj = new Object()
			obj.name = $(".child-boxt").eq(i).find("#i_Name").val();
			obj.label = $(".child-box").eq(i).find("#i_Label").val();
			obj.helptext = $(".child-box").eq(i).find("#i_HelpText").val();;
			obj.buttion = $(".child-box").eq(i).find("button").attr("class");
			obj.option = $(".child-box").eq(i).find("select").val();
			if ($(".child-box #required").is(":checked")) {
				obj.required = true;
			} else obj.required = false;
			obj.object = "newObject"
			if($(".child-box").eq(i).find("#OptionItem1").length == 1){
				obj.type = "Autocomplete"
			}
			else if($(".child-box").eq(i).find("#OptionItem2").length === 1){
				obj.type = "Button"
			}
			list.push(obj);
		}

		var lists = JSON.stringify(list);
		$.ajax({
			contentType: 'application/json',
			url: "/Home/Index",
			dataType: "json",
			type: "POST",
			data: lists,
			success: function () {
				alert("gui thanh cong")
			},
			error: function () {
				alert("that bai")
			}
		})
	})
})

