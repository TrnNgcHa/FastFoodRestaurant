document.addEventListener('DOMContentLoaded', function () {
    var filters = document.querySelectorAll('.filters_menu li');
    var items = document.querySelectorAll('.filters-content .grid .all');

    function applyFilter(filter) {
        filters.forEach(function (f) {
            if (f.dataset.filter === filter) f.classList.add('active');
            else f.classList.remove('active');
        });

        if (filter === '*') {
            items.forEach(function (it) { it.style.display = ''; });
            return;
        }

        var className = filter.replace(/^\./, '');
        items.forEach(function (it) {
            if (it.classList.contains(className)) it.style.display = '';
            else it.style.display = 'none';
        });
    }

    filters.forEach(function (f) {
        f.addEventListener('click', function () { applyFilter(f.dataset.filter); });
        f.addEventListener('keydown', function (e) {
            if (e.key === 'Enter' || e.key === ' ') { e.preventDefault(); applyFilter(f.dataset.filter); }
        });
    });

    // initialize
    var initial = document.querySelector('.filters_menu li.active');
    if (initial) applyFilter(initial.dataset.filter);
});
