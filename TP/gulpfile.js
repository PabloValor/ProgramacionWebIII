'use strict';
var path 			= require('path'),
	gulp 			= require('gulp'),
	sass 			= require('gulp-sass'),
	concatFiles 	= require('gulp-concat'),
	cssmin 			= require('gulp-cssmin'),
	rename			= require('gulp-rename'),
	uglify 			= require('gulp-uglify');

var paths = {
	css: {
		src: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\css',
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
  return gulp.src(paths.css.src + '\\main.scss')
    .pipe(sass().on('error', sass.logError))
	.pipe(cssmin({ keepSpecialComments: 0 }))
	.pipe(rename({ suffix: '.min'}))
    .pipe(gulp.dest(paths.css.dest));
});

gulp.task('watch', function(){
	gulp.watch(paths.css.src + '\\*.scss', ['sass']);
});

gulp.task('default', ['sass', 'watch']);