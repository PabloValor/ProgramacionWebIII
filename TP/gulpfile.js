'use strict';
var path = require('path');
var gulp = require('gulp');
var sass = require('gulp-sass');
var fs = require('fs');

var paths = {
	css: {
		src: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\css\\main.scss',
		dest: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\css\\dist',
	},
	js: {
		src: '',
		dest: '',
		vendors: {
			src: ''
		}
	},
	img: {
		src: '',
		dest: '',
		vendors: {
			src: ''
		}
	}
};


gulp.task('sass', function () {
  return gulp.src(paths.css.src)
    .pipe(sass().on('error', sass.logError))
    .pipe(gulp.dest(paths.css.dest));
});

gulp.task('default', function(){
	return console.log('hola');
});
