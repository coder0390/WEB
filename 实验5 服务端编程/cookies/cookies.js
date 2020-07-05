/*注册页面*/
$(function () {
    $('#sign').click(function () {
		var name = $('#u_name').val();
		setCookie(name);
		checkCookie(name);
    });
});

// 设置cookies，用户姓名出现的次数+时间的键值对
function setCookie(u_name)
{
	var count = parseInt(getCookie(u_name));
	if(count==-1){
		document.cookie = document.cookie + u_name + "=" + 1 + "-";		//第一次设置
	}
	else{
		document.cookie = document.cookie + u_name + "=" + (count+1) + "-";		//追加设置
	}
}

//获得cookie
function getCookie(u_name){
	var name = u_name + "=";
	var ca = document.cookie.split('-');
	if(ca.length>1){
		for(var i=ca.length-1; i>=0; i--) {
			var c = ca[i].trim();    // 去除两端空白字符，返回name最后出现的位置
			if (c.indexOf(name)==0)  //找到用户名出现的下标，加入返回数组
		    	return c.substring(name.length,c.length);
		}
	}
	return -1;
}

//检查cookie
function checkCookie(name){
	var count = parseInt(getCookie(name));
	alert(name+",欢迎您第"+(count)+"次访问本站！");
	alert(document.cookie);
}