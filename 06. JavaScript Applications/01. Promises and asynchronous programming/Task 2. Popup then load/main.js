window.onload =
    function () {
        var popUp = document.getElementById('popUp');
        console.log(popUp);
        var msg = 'Redirecting to ';
        var link = '9gag.com';
        popUp.innerHTML = msg + link + '...';

        var wait2secs = new Promise((resolve, reject) => {
            setTimeout(resolve, 3000);
        });

        function redirect(link) {
            window.location.href = 'http://www.' + link;
        }
        wait2secs.then(() => redirect(link));
    }