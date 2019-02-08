// Gulp 4

var { src, dest, parallel, series } = require('gulp');
var minifyCSS = require('gulp-csso');
var concat = require('gulp-concat');
var uglify = require('gulp-uglify');
var inject = require('gulp-inject');
var removeCode = require('gulp-remove-code');
var sourcemaps = require('gulp-sourcemaps');
var watch = require('gulp-watch');

let vendorPackages = [
  'node_modules/jquery/dist/jquery.min.js',
];

function html() {
  return src(['*.html'])
      .pipe(inject(src(['./build/js/*.js', './build/**/*.css'], { read: false }),
        {ignorePath: 'build', addRootSlash: false }))
      .pipe(removeCode({ production: true }))
      .pipe(dest('build'));
}

function js() {
  return src('*.js', { sourcemaps: true })
    .pipe(sourcemaps.init())
    .pipe(concat('app.min.js'))
    .pipe(uglify())
    .pipe(sourcemaps.write('.'))
    .pipe(dest('build/js'));
}

function vendor_js() {
  return src(vendorPackages)
    .pipe(concat('vendor.min.js'))
    .pipe(dest('build/js'))
}

function css() {
  return src('*.css')
    .pipe(sourcemaps.init())
    .pipe(concat('app.min.css'))
    .pipe(minifyCSS())
    .pipe(sourcemaps.write('.'))
    .pipe(dest('build/css'))
}

function images() {
  return src('*.jpg')
    .pipe(dest('build/images'))
}

function watch_files() {
  watch('*.html', html);
  watch('*.js', js);
  watch('*.css', css);
}

exports.js = js;
exports.css = css;
//exports.default = series(vendor_js, js, css, images, html);
exports.default = series(vendor_js, js, css, images, html, watch_files);