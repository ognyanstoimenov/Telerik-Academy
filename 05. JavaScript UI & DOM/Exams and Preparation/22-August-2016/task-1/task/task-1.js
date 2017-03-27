function solve() {
    return function (selector, tabs) {
        var element = document.querySelector(selector);
        var fragment = document.createDocumentFragment();

        var tabsNav = document.createElement('ul');
        tabsNav.className = 'tabs-nav';
        tabs.forEach(function (tab, i) {
            var anchor = document.createElement('a');
            anchor.className = 'tab-link';
            anchor.setAttribute('id', i);
            anchor.innerHTML = tab.title;

            var li = document.createElement('li');
            li.appendChild(anchor);
            tabsNav.appendChild(li);
        });
        fragment.appendChild(tabsNav);

        var tabsContent = document.createElement('ul');
        tabsContent.className = 'tabs-content';
        tabs.forEach(function (tab, i) {
            var p = document.createElement('p');
            p.innerHTML = tab.content;

            var button = document.createElement('button');
            button.className = 'btn-edit';
            button.innerHTML = 'Edit';

            var li = document.createElement('li');
            li.className = 'tab-content';
            if (i == 0) {
                li.className += ' visible';
            }
            li.appendChild(p);
            li.appendChild(button);
            tabsContent.appendChild(li);
        });
        fragment.appendChild(tabsContent);

        var currentTab = tabsContent.children[0];
        tabsNav.addEventListener('click', function (e) {
            var target = e.target.tagName === 'A' ? e.target : e.target.querySelector('a');
            var targetId = target.id;

            var targetContent = tabsContent.children[targetId];
            targetContent.className += ' visible';

            currentTab.className = currentTab.className.replace(/\bvisible\b/, '');

            currentTab = targetContent;
        });

            var txtArea;
        tabsContent.addEventListener('click', function (e) {
            if (e.target.className.indexOf('btn-edit') < 0) {
                return;
            }
            var currButton = e.target;
            var currentContent = currButton.previousSibling;
            txtArea = document.createElement('textarea');
            txtArea.className += '.edit-content';
            txtArea.innerHTML = currentContent.innerHTML;
            if (currButton.innerHTML === 'Edit') {
                currButton.parentElement.appendChild(txtArea);
                currButton.innerHTML = 'Save';
            }
            else {
                currentContent.innerHTML = txtArea.value;               
                currButton.parentElement.removeChild(txtArea);
                currButton.innerHTML = 'Edit';
            }

        });

        element.appendChild(fragment);

    }
}

if (typeof module !== 'undefined') {
    module.exports = solve;
}