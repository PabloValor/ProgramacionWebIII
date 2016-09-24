var path 			= require('path'),
	gulp 			= require('gulp'),
	sass 			= require('gulp-sass'),
	concatFiles 	= require('gulp-concat'),
	cssmin 			= require('gulp-cssmin'),
	rename			= require('gulp-rename'),
	uglify 			= require('gulp-uglify'),
	jslint 			= require('gulp-jslint');
	

var BASE_PATH = 'D:\\repos\\ProgramacionWebIII\\TP\\';

var paths = {
	css: {
		vendor: {
			materialize: BASE_PATH + 'bower_components\\materialize\\dist\\css\\materialize.css'
		},
		src: BASE_PATH + 'AlquilaCocheras.Web\\assets\\css',
		dist: BASE_PATH + 'AlquilaCocheras.Web\\assets\\css\\dist',
	},
	js: {
		src: BASE_PATH + 'AlquilaCocheras.Web\\assets\\js',
		vendor: {
			jquery: BASE_PATH + 'bower_components\\jquery\\dist\\jquery.js',
			materialize: BASE_PATH + 'bower_components\\materialize\\dist\\js\\materialize.js'
		},
		componentes: {
			baseLayout: BASE_PATH + 'AlquilaCocheras.Web\\assets\\js\\shared\\layout-base.js'
		},
		dist: BASE_PATH + 'AlquilaCocheras.Web\\assets\\js\\dist'
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
	return gulp.src([paths.css.vendor.materialize, paths.css.src + '\\main.scss'])
		.pipe(sass().on('error', sass.logError))
		.pipe(cssmin({ keepSpecialComments: 0 }))
		.pipe(rename({ basename: 'estacionalo', suffix: '.min'}))
		.pipe(gulp.dest(paths.css.dist));
});

gulp.task('js.vendor', function(){
	return gulp.src([
		paths.js.vendor.jquery,
		paths.js.vendor.materialize
		])
		.pipe(concatFiles('vendors.js'))
		.pipe(gulp.dest(paths.js.dist))
});

gulp.task('js.componentes', function(){
	return gulp.src([
		paths.js.componentes.baseLayout
		])
		.pipe(concatFiles('componentes.js'))
		//.pipe(jslint({this: true}))
		//.pipe(jslint.reporter('default'))
		//.pipe(jslint.reporter('stylish'))
		.pipe(gulp.dest(paths.js.dist));
});

gulp.task('js', ['js.vendor', 'js.componentes'], function(){
	return gulp.src([
		paths.js.dist + '\\vendors.js',
		paths.js.dist + '\\componentes.js'
		])
		.pipe(concatFiles('estacionalo.js'))
		.pipe(gulp.dest(paths.js.dist))
		.pipe(uglify({ compress: true }))
		.pipe(rename({ basename: 'estacionalo', suffix: '.min' }))
		.pipe(gulp.dest(paths.js.dist));
});

gulp.task('watch', function(){
	gulp.watch(paths.css.src + '\\*.scss', ['css']);
	gulp.watch([paths.js.src + '\\**\\*.js', '!' + paths.js.dist + '\\*.js'], ['js']);
});

gulp.task('default', ['css', 'js.vendor', 'js', 'watch']);