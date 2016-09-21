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
		vendor: {
			bootstrap: 'D:\\repos\\ProgramacionWebIII\\TP\\bower_components\\bootstrap\\dist\\css\\boostrap.css'
		},
		src: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\css',
		dest: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\css\\dist',
	},
	js: {
		vendor: {
			jquery: 'D:\\repos\\ProgramacionWebIII\\TP\\bower_components\\jquery\\dist\\jquery.js',
			bootstrap: 'D:\\repos\\ProgramacionWebIII\\TP\\bower_components\\bootstrap\\dist\\js\\bootstrap.js'
		},
		src: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\js',
		dest: 'D:\\repos\\ProgramacionWebIII\\TP\\AlquilaCocheras.Web\\assets\\js\\dist'
	},
	img: {
		src: '',
		dest: '',
		vendor: {
			src: ''
		}
	}
};


gulp.task('css', function () {
	return gulp.src([paths.css.vendor.bootstrap, paths.css.src + '\\main.scss'])
		.pipe(sass().on('error', sass.logError))
		.pipe(cssmin({ keepSpecialComments: 0 }))
		.pipe(rename({ suffix: '.min'}))
		.pipe(gulp.dest(paths.css.dest));
});

gulp.task('js.vendor', function(){
	return gulp.src([paths.js.vendor.jquery, paths.js.vendor.bootstrap])
		.pipe(concatFiles('vendors.js'))
		.pipe(gulp.dest(paths.js.dest))
		.pipe(uglify({ compress: true }))
		.pipe(rename({ basename: 'vendors', suffix: '.min' }))
		.pipe(gulp.dest(paths.js.dest));
		
});

gulp.task('watch', function(){
	gulp.watch(paths.css.src + '\\*.scss', ['css']);
	gulp.watch([paths.js.src + '\\*.js', '!' + paths.js.dist + '*.js'], ['js.vendor']);
});

gulp.task('default', ['css', 'js.vendor', 'watch']);