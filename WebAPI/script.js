  (async () => {
    try {
      var response = await fetch("http://localhost:15034/KontorMobler");
      var data = await response.json();
      console.log(data);
    } catch (e) {
      console.log('Run the backend');
    }
  })();

  (async () => {
    try {
      var response = await fetch("http://localhost:15034/KontorMobler", {method: 'POST'});
      var data = await response.json();
      console.log(data);
    } catch (e) {
      console.log('Run the backend');
    }
  })();