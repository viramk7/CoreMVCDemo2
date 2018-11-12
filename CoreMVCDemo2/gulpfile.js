/// <binding beforebuild='clean' clean='clean' />
"use strict";

const gulp = require("gulp"),
    rimraf = require("rimraf"),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin"),
    uglify = require("gulp-uglify"),
    rename = require("gulp-rename");

const paths = {
    webroot: "./wwwroot/"
};

paths.js = paths.webroot + "js/**/*.js";
paths.minjs = paths.webroot + "js/**/*.min.js";
paths.css = paths.webroot + "css/**/*.css";
paths.mincss = paths.webroot + "css/**/*.min.css";
paths.concatjsdest = paths.webroot + "js/site.min.js";
paths.concatcssdest = paths.webroot + "css/site.min.css";

gulp.task("clean:js", done => rimraf(paths.concatjsdest, done));
gulp.task("clean:css", done => rimraf(paths.concatcssdest, done));
gulp.task("clean", gulp.series(["clean:js", "clean:css"]));


//gulp.task('cleanNested', [], function () {
//    return gulp.src([paths.js, "!" + paths.minjs], { read: false }).pipe(rimraf());
//});

gulp.task("min:nestedJs", () => {
    return gulp.src([paths.js, "!" + paths.minjs], { base: "." })
        .pipe(rimraf(this))
        //.pipe(concat(paths.concatjsdest))
        .pipe(uglify())
        .pipe(rename({ suffix: '.min' }))
        .pipe(gulp.dest(function (file) {
            return file.base;
        }));
});

gulp.task("min:js", () => {
    return gulp.src([paths.js, "!" + paths.minjs], { base: "." })
        .pipe(concat(paths.concatjsdest))
        .pipe(uglify())
        .pipe(gulp.dest("."));
});

gulp.task("min:css", () => {
    return gulp.src([paths.css, "!" + paths.mincss])
        .pipe(concat(paths.concatcssdest))
        .pipe(cssmin())
        .pipe(gulp.dest("."));
});

gulp.task("min", gulp.series(["min:nestedJs","min:js", "min:css"]));

// a 'default' task is required by gulp v4
gulp.task("default", gulp.series(["min"]));