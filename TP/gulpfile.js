'use strict';
var gulp = require('gulp');
var less = require('gulp-less');

var paths = {
	base: '',
	css: {
		src: '',
		dest: '',
		vendors: {
			src: ''
		}
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

gulp.task('default', function(){
	return console.log('hola');
});
