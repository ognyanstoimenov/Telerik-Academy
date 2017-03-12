/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve() {
  return function (selector) {
    const element = (typeof selector === 'string') ? document.getElementById(selector) : selector;
    if (!element instanceof HTMLElement) {
      throw Error();
    }

    Array.from(element.getElementsByClassName('button')).forEach(x => x.innerHTML = 'hide');

    element.addEventListener('click', function (e) {
      const currBtn = e.target;

      if (currBtn.className !== 'button') {
        return;
      }

      var currElement = currBtn.nextElementSibling;
      while (currElement.className !== 'button') {
        if (currElement.className === 'content') {
          if (currBtn.innerHTML === 'hide') {
            currBtn.innerHTML = 'show';
            currElement.style.display = 'none';
          }
          else {
            currBtn.innerHTML = 'hide';
            currElement.style.display = '';
          }
          break;
        }
        currElement = currElement.nextElementSibling;
        if (!currElement) break;
      }
    });

  };
};

module.exports = solve;