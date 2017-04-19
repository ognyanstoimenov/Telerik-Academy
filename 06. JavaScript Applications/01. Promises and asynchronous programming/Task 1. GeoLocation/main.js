var getLocation = new Promise((resolve, reject) => {
	navigator.geolocation.getCurrentPosition(resolve);
});

function toObj(location) {
	if (location.coords.longitude && location.coords.latitude) {
		return {
			latitude: location.coords.latitude,
			longtitude: location.coords.longitude
		};
	};
}
function visualizeLoc(coord) {
	var img = document.getElementById('geo-map');
	var src = `https://maps.googleapis.com/maps/api/staticmap?center=${coord.latitude},${coord.longtitude}&zoom=17&size=400x400`;
	img.setAttribute('src', src);
}

getLocation
	.then(toObj)
	.then(visualizeLoc);